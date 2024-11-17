const express = require('express');
const bodyParser = require('body-parser');
const paymentRoutes = require('./routes/payment');
require('dotenv').config();

const app = express();
const PORT = 3000;

// Middleware
app.use(bodyParser.json());
app.use('/api/payment', paymentRoutes);

// Start Server
app.listen(PORT, () => {
    console.log(`Server running on http://localhost:${PORT}`);
});
