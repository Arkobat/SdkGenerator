package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PolicyDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String PolicyName;
        @NotNull
    	private PersonDto PolicyHolder;
        @NotNull
    	private double CoverageAmount;
        @NotNull
    	private DateTime StartDate;
        @Nullable
    	private DateTime EndDate;
        @Nullable
    	private InsuranceDto Insurances;
    
    
    
}