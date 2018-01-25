import { Response, Request } from "express";

export = (req: Request, res: Response) => {
    res.status(200).json(require("./data").bikes.find((m:Bike) => m.id === parseInt(req.param("id", 0))));
};