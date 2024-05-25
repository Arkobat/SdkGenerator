package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SentenceDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Description;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private CaseDto Case;
        @Nullable
    	private SettlementDto Settlement;
        @Nullable
    	private FineDto Fine;
    
    
    
}