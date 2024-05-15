import { JsonProperty } from "json-object-mapper";
import { Company } from "./company";

export class Job {
	@JsonProperty({ required: true })
	public title: string;

	@JsonProperty({ required: true })
	public company: Company;

	@JsonProperty({ name: "started_at", required: true })
	public startedAt: Date;
}
