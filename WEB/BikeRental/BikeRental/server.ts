import * as express from "express";
import routes from "./routes";
let app = express();
app.use("/", routes);
app.listen(process.env.port || 1337);