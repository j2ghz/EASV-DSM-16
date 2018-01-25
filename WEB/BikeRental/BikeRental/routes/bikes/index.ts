import * as express from "express";
import { Request, Response } from "express";
var router = express.Router();
router.get("/",
    (req: Request, res: Response) => {
        res.status(200).json(require("./data").bikes);
    });
router.get("/:id",
    (req: Request, res: Response) => {
        res.status(200).json(require("./data").bikes.find((m: Bike) => m.id === parseInt(req.param("id", 0))));
    });
export = router;