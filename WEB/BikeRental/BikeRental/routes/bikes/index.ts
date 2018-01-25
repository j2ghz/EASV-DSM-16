import express = require("express");
var router = express.Router();
router.get("/", require("./all" ));
export = router;