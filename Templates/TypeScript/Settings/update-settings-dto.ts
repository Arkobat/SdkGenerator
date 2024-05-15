import { JsonProperty } from "json-object-mapper";
export class UpdateSettingDto<T> {
	@JsonProperty({ required: true })
	public path: string;

	@JsonProperty({ required: true })
	public value: T;

	@JsonProperty({ required: true })
	public operation: Operation;
}

export enum Operation {
	Set,
	Add,
	Remove,
}
