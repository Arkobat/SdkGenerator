package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class InsuranceClaimDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String ClaimNumber;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private PersonDto Claimant;
        @NotNull
    	private InsuranceDto Insurance;
    
    
    
}