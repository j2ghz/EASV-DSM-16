import { prop, Typegoose, ModelType, InstanceType } from "mongoose";

export class Bike extends Typegoose {
    @prop()
    id: number;
    @prop()
    name: string;
    @prop()
    modelId: number;
};