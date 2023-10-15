'use strict';
var http = require('http');
var port = process.env.PORT || 8080;

// Define an array to store IP addresses
const ipAddresses = [];

const server = http.createServer((req, res) => {
    if (req.method === 'GET') {
        // Respond with the list of IP addresses as JSON
        res.setHeader('Content-Type', 'application/json');
        res.end(JSON.stringify(ipAddresses));
    } else {
        res.statusCode = 405; // Method Not Allowed
        res.end('Method not allowed');
    }
});

server.listen(8080, () => {
    console.log('Server is running on port 8080');
});

server.on('request', (req) => {
    const clientIP = req.connection.remoteAddress;

    // Extract only numbers and dots from the IP address
    const ipv4Address = clientIP.match(/[0-9.]+/);

    if (ipv4Address) {
        const cleanedIP = ipv4Address[0];
        if (ipAddresses.indexOf(cleanedIP) === -1) {
            ipAddresses.push(cleanedIP);
            console.log(`Captured IPv4 Address: ${cleanedIP}`);
        }
    }
});

