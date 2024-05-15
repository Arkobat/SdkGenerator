import { JsonProperty } from "json-object-mapper";
import { Address } from "./address";
import { Job } from "./job";

export class Person {
	@JsonProperty({ name: "first_name", required: true })
	public firstName: string;

	@JsonProperty({ name: "last_name", required: true })
	public lastName: string;

	@JsonProperty({ required: true })
	public age: number;

	@JsonProperty({ required: true })
	public address: Address;

	@JsonProperty({ required: true })
	public jobs: Job[];

	@JsonProperty({ required: false })
	public parent?: Person;

	@JsonProperty({ required: false })
	public child?: Person;
}
