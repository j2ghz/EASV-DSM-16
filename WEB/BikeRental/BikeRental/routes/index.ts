import bikes from "./bikes";
import * as express from "express";
var router = express.Router();
router.get("/",
    (req, res) => {
        res.status(404);
    });
router.use("/bikes", bikes);
export default router;