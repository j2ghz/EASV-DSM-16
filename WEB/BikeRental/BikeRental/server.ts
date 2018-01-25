import express = require("express");
let app = express();
app.use("/", require("./routes"));
app.listen(process.env.port || 1337);