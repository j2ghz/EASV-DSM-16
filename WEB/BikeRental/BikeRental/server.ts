import * as express from "express";
import routes from "./routes";
import * as db from "mongoose";

let app = express();
app.use("/", routes);
app.listen(process.env.port || 1337);


db.connect("mongo:/localhost:27017/BikeRental");


