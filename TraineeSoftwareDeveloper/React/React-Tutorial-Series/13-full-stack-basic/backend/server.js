import express from "express";

const app = express();

app.get('/', (req, res) => {
    res.send('Server is Ready');
});

app.get('/api/jokes', (req, res) => {
    const jokes = [
        {id:1, title:'A Joke'},
        {id:2, title:'Another Joke'},
        {id:3, title:'Third Joke'},
        {id:4, title:'Forth Joke'},
        {id:5, title:'Fifth Joke'},
    ];
    res.send(jokes);
});

const port = process.env.PORT || 3000;

app.listen(port, () => {
    console.log(`Server at http://localhost:${port}`);
});
