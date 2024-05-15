import { JsonProperty } from "json-object-mapper";
import { Hit } from "./hit";
export class HitsMetadata<TDocument> {
	@JsonProperty({ name: "hits" })
	public hits: Hit<TDocument>[];

	@JsonProperty({ name: "max_score" })
	public maxScore?: number;

	@JsonProperty({ name: "total" })
	public total: number;
}
