package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class SettlementDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Terms;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private CaseDto Case;
        @NotNull
    	private PersonDto SettlingParty;
    
    
    
}