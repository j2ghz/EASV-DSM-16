import * as express from "express";
import { Request, Response } from "express";
import {json} from "body-parser";
var router = express.Router();
var data: Array<Bike> = require("./data");
router.get("/",
    (req: Request, res: Response) => {
        res.status(200).json(data);
    });
router.get("/:id",
    (req: Request, res: Response) => {
        res.status(200).json(data.find((m: Bike) => m.id === parseInt(req.param("id", 0))));
    });
router.post("/",
    json,
    (req: Request, res: Response) => {
        var toAdd: Bike = req.body;
        data.push(toAdd);
        res.status(204);
    });
export = router;