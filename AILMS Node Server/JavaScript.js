const express = require('express');
const app = express();
const port = 3000;

// Middleware to parse incoming data
app.use(express.json());

// Store session data (you can use an in-memory object or a database)
const sessions = {};

app.post('/create-session', (req, res) => {
    const { studentNumber } = req.body;

    // Generate a session ID
    const sessionID = `Session: ${Math.random().toString(36).substring(7)}`;
    const sessionData = `Session: ${sessionID}\nStudent Number: ${studentNumber}`;

    // Store the session data
    sessions[sessionID] = sessionData;

    res.json({ sessionID });
});

app.get('/session/:sessionID', (req, res) => {
    const sessionID = req.params.sessionID;
    const sessionData = sessions[sessionID];
    if (sessionData) {
        res.send(sessionData);
    } else {
        res.status(404).send('Session not found');
    }
});

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});
