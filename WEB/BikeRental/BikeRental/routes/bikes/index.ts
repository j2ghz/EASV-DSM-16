import { Request, Response } from "express";
import { json } from "body-parser";
import { bikeModel } from "../../models/Bike"
import express from "express";

var router = express.Router();
router.get("/",
    async (req: Request, res: Response) => {
        await bikeModel.find((err, bikes) => {
            if (err) {
                res.status(500).send(err);
            }
            res.status(200).send(bikes);
        });
    });
//router.get("/:id",
//    (req: Request, res: Response) => {
//        res.status(200).json(data.find((m: Bike) => m.id === parseInt(req.param("id", 0))));
//    });
router.post("/",
    json,
    async (req: Request, res: Response) => {
        await new bikeModel(req.body).save((err) => {
            if (err) {
                res.status(500).send(err);
            } else {
                res.status(204);
            }
        });

    });
export default router;