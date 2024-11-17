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

module.exports = router;
