import { JsonProperty } from "json-object-mapper";
import { Hit } from "./hit";

export class MultiSearchItem<TDocument> {
	@JsonProperty({ required: false })
	public fields?: { [key: string]: any };

	@JsonProperty({ name: "hits" })
	public hits: Hit<TDocument>[];

	@JsonProperty({ name: "max_score" })
	public maxScore?: number;

	@JsonProperty({ name: "num_reduce_phases" })
	public numReducePhases?: number;

	@JsonProperty({ name: "pit_id" })
	public pitId?: string;

	@JsonProperty({ name: "status" })
	public status?: number;

	@JsonProperty({ name: "terminated_early" })
	public terminatedEarly?: boolean;

	@JsonProperty({ name: "timed_out" })
	public timedOut: boolean;

	@JsonProperty({ name: "took" })
	public took: number;
}
