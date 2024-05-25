package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class InsuranceDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String PolicyNumber;
        @NotNull
    	private String Provider;
        @NotNull
    	private PersonDto Insured;
        @NotNull
    	private double CoverageAmount;
        @NotNull
    	private PolicyDto Policy;
    
    
    
}