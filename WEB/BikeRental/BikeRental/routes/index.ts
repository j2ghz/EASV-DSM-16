import bikes from "./bikes";
import { Request, Response, NextFunction, Router } from "express";
var router: Router = Router();
router.get("/",
    (request: Request, response: Response) => {
        response.json({
            name: "Express application"
        });
    });

router.use((err: Error & { status: number }, request: Request, response: Response, next: NextFunction): void => {

    response.status(err.status || 500);
    response.json({
        error: "Server error"
    });
});
router.use("/bikes", bikes);
export default router;