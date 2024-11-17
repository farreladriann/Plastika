const express = require('express');
const bodyParser = require('body-parser');
const { Client } = require('pg');
require('dotenv').config();
const paymentRoutes = require('./routes/payment');
const app = express();
const PORT = 3000;

// Middleware
app.use(bodyParser.json());
app.use('/api/payment', paymentRoutes);

// Parse DB_URI into a connection object
function parseDbUri(uri) {
    const params = uri.split(';').reduce((acc, param) => {
        const [key, value] = param.split('=');
        if (key && value) {
            acc[key.toLowerCase()] = value;
        }
        return acc;
    }, {});

    return {
        host: params['host'],
        user: params['username'],
        password: params['password'],
        database: params['database'],
        port: params['port'] || 5432, // Default PostgreSQL port
        ssl: {
            rejectUnauthorized: false, // Allow self-signed or non-verified certificates
        },
    };
}

// Parse the DB_URI
const dbConfig = parseDbUri(process.env.DB_URI);

// Log the parsed configuration for debugging
console.log('Parsed DB Config:', dbConfig);

// Database connection
const client = new Client(dbConfig);

// Connect to the database
client.connect(err => {
    if (err) {
        console.error('Failed to connect to the database:', err.stack);
    } else {
        console.log('Connected to the database successfully!');
    }
});

// Handle success callback and stock update
app.get('/api/payment/success', async (req, res) => {
    const { order_id } = req.query;

    try {
        const result = await client.query(`
            SELECT id_product, quantity, is_product 
            FROM orders 
            WHERE order_id = $1`, [order_id]);

        if (result.rowCount === 0) {
            return res.status(404).json({ status: 'error', message: 'Order not found.' });
        }

        const { id_product, quantity, is_product } = result.rows[0];

        const table = is_product ? '"Products"' : '"Trashes"';
        const column = is_product ? 'id_product' : 'id_trash';

        await client.query(`
            UPDATE pub_plastika.${table}
            SET quantity = quantity - $1
            WHERE ${column} = $2`, [quantity, id_product]);

        res.status(200).json({ status: 'success', message: 'Payment successful and stock updated.' });
    } catch (error) {
        console.error('Error updating stock:', error.stack);
        res.status(500).json({ status: 'error', message: 'Failed to update stock.' });
    }
});

// Start Server
app.listen(PORT, () => {
    console.log(`Server running on http://localhost:${PORT}`);
});
