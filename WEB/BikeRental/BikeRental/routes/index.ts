import express = require("express");
export var router = express.Router();
router.get("/",
    (req, res) => {
        res.status(404);
    });
router.use("/bikes", require("./bikes"));