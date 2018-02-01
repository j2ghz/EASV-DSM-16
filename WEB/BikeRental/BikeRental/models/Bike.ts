import { Document, Model, Schema } from "mongoose";
import { mongoose } from "../database";

export interface IBike extends Document {
    name: string;
}

export interface IBikeModel extends Model<IBike> {
    
}

const schema = new Schema({
    name: { type: String, required: true }
});

export const bike = mongoose.model<IBike>("Author", schema) as IBikeModel;