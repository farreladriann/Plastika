const express = require('express');
const bodyParser = require('body-parser');
const paymentRoutes = require('./routes/payment');
const { Pool } = require('pg');
require('dotenv').config();

const app = express();
const PORT = 3000;

// Middleware
app.use(bodyParser.json());
app.use('/api/payment', paymentRoutes);

// Database connection
const pool = new Pool({
    connectionString: process.env.DB_URI, // Use the DB_URI from .env file
});

// Test database connection
pool.connect((err, client, release) => {
    if (err) {
        console.error('Failed to connect to the database:', err.stack);
    } else {
        console.log('Connected to the database successfully!');
        release();
    }
});



// Start Server
app.listen(PORT, () => {
    console.log(`Server running on http://localhost:${PORT}`);
});

// Handle success callback and stock update
app.get('/api/payment/success', async (req, res) => {
    const { order_id } = req.query;

    try {
        const result = await pool.query(`
            SELECT id_product, quantity, is_product 
            FROM orders 
            WHERE order_id = $1`, [order_id]);

        if (result.rowCount === 0) {
            return res.status(404).json({ status: 'error', message: 'Order not found.' });
        }

        const { id_product, quantity, is_product } = result.rows[0];

        const table = is_product ? '"Products"' : '"Trashes"';
        const column = is_product ? 'id_product' : 'id_trash';

        await pool.query(`
            UPDATE pub_plastika.${table}
            SET quantity = quantity - $1
            WHERE ${column} = $2`, [quantity, id_product]);

        res.status(200).json({ status: 'success', message: 'Payment successful and stock updated.' });
    } catch (error) {
        console.error('Error updating stock:', error.stack);
        res.status(500).json({ status: 'error', message: 'Failed to update stock.' });
    }
});

