import { Request, Response, Router } from "express";
import { bikeModel } from "./../../models/Bike";

let router: Router = Router();

router.get("/",
    (req: Request, res: Response) => {
        console.log("Requested");
        bikeModel.find({},
            (err, bikes) => {
                console.log("db rec");
                console.log(err);
                console.log(bikes);
                if (err) {
                    res.status(500).send(err);
                }
                res.json(bikes);
            });
        console.log("Done");
    });

//router.get("/:id",
//    (req: Request, res: Response) => {
//        res.status(200).json(data.find((m: Bike) => m.id === parseInt(req.param("id", 0))));
//    });

//router.post("/",
//    async (req: Request, res: Response) => {
//        const bike = await bikeModel.create(req.body);

//        res.status(204).json(bike);

//    });

export default router;