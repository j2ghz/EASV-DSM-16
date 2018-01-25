import { router } from "./routes";
import * as express from "express";
let app = express();
app.use("/", router);
app.listen(process.env.port || 1337);