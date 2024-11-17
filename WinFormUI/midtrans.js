{
  "exclude": [
    "**/bin",
    "**/bower_components",
    "**/jspm_packages",
    "**/node_modules",
    "**/obj",
    "**/platforms"
  ]
}

const midtransClient = require('midtrans-client');

// Create Snap API instance
const snap = new midtransClient.Snap({
    isProduction: false, // Set to true if you're in production
    serverKey: 'SB-Mid-server-06d6gb9wjhdUHglHhdvqEhn-', // Replace with your actual Server Key
});

const createTransaction = async (req, res) => {
    try {
        const parameter = {
            transaction_details: {
                order_id: `order-${Date.now()}`, // Generate a unique order ID
                gross_amount: 10000, // Replace with the actual amount
            },
            customer_details: {
                first_name: 'John',
                email: 'john@example.com',
                phone: '081234567890',
            },
        };

        // Create the transaction
        const transaction = await snap.createTransaction(parameter);

        // Respond with the transaction token
        res.json({ token: transaction.token });
    } catch (error) {
        console.error('Error creating transaction:', error);
        res.status(500).json({ error: 'Failed to create transaction' });
    }
};

module.exports = { createTransaction };
