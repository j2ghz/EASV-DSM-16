import express = require("express");
var router = express.Router();
router.get("/", require("./all"));
router.get("/:id", require("./single"));
export = router;