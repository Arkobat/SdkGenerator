import { JsonProperty } from "json-object-mapper";

export class Hit<TDocument> {
	@JsonProperty({ name: "_id", required: true })
	public id: string;

	@JsonProperty({ name: "_index", required: true })
	public index: string;

	@JsonProperty({ required: false })
	public fields?: { [key: string]: any };

	@JsonProperty({ required: false })
	public highlight?: { [key: string]: string[] };

	@JsonProperty({ name: "_ignored", required: false })
	public ignored?: string[];

	@JsonProperty()
	public matchedQueries?: string[];

	@JsonProperty({ name: "_node", required: false })
	public node?: string;

	@JsonProperty({ name: "_primary_term", required: false })
	public primaryTerm?: number;

	@JsonProperty({ name: "_routing", required: false })
	public routing?: string;

	@JsonProperty({ name: "_score", required: false })
	public score?: number;

	@JsonProperty({ name: "_seq_no", required: false })
	public seqNo?: number;

	@JsonProperty({ name: "_shard", required: false })
	public shard?: string;

	@JsonProperty({ name: "_source", required: false })
	public source?: TDocument;

	@JsonProperty({ name: "_version", required: false })
	public version?: number;
}
