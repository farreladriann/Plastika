const express = require('express');
const midtransClient = require('midtrans-client');
require('dotenv').config();

const router = express.Router();

// Initialize Snap API client
const snap = new midtransClient.Snap({
    isProduction: process.env.MIDTRANS_IS_PRODUCTION === 'true', // Use false for sandbox
    serverKey: process.env.MIDTRANS_SERVER_KEY,                 // Ensure this is correct
    clientKey: process.env.MIDTRANS_CLIENT_KEY
});

//const parameter = {
//    transaction_details: { order_id, gross_amount },
//    customer_details,
//    callbacks: {
//        finish: "http://localhost:3000/payment-finished" // Replace with your actual callback URL
//    },
//};


// Create transaction endpoint
router.post('/create-transaction', async (req, res) => {
    try {
        const { order_id, gross_amount, customer_details } = req.body;

        const parameter = {
            transaction_details: { order_id, gross_amount },
            customer_details,
        };

        // Log server key for debugging
        console.log('Server Key:', process.env.MIDTRANS_SERVER_KEY);

        // Create transaction
        const transaction = await snap.createTransaction(parameter);

        res.status(200).json({
            status: 'success',
            token: transaction.token,
            redirect_url: transaction.redirect_url,
        });
    } catch (error) {
        console.error('Midtrans Error:', error);
        res.status(500).json({ status: 'error', message: error.ApiResponse?.error_messages[0] || 'Failed to create transaction.' });
    }
});

router.get('/payment-finished', async (req, res) => {
    const { order_id, status_code } = req.query;

    if (status_code === '200') {
        // Payment successful, update stock logic
        console.log(`Payment successful for order ${order_id}`);

        // Example: Call your database to reduce the stock
        const updatedStock = await updateStock(order_id);

        // Redirect user back to your application
        res.redirect(`myapp://HalamanUtama?success=true&order_id=${order_id}`);
    } else {
        // Payment failed or canceled
        console.log(`Payment failed or canceled for order ${order_id}`);
        res.redirect(`myapp://HalamanUtama?success=false&order_id=${order_id}`);
    }
});

async function updateStock(orderId) {
    // Custom logic to reduce stock based on the order
    // Example: Fetch the order details, calculate the remaining stock, and update the database
}


module.exports = router;
