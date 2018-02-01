import { Request, Response, Router } from "express";
import { json } from "body-parser";
import { bikeModel } from "./../../models/Bike";

let router: Router = Router();

router.get("/",
    async (req: Request, res: Response) => {

        const bikes = await bikeModel.find({}).exec();

        res.json(bikes);
    });

//router.get("/:id",
//    (req: Request, res: Response) => {
//        res.status(200).json(data.find((m: Bike) => m.id === parseInt(req.param("id", 0))));
//    });

router.post("/",
    async (req: Request, res: Response) => {
        const bike = await bikeModel.create(req.body);

        res.status(204).json(bike);

    });

export default router;