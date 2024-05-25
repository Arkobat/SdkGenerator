package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class BenefitDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Description;
        @NotNull
    	private PersonDto Beneficiary;
        @NotNull
    	private InsuranceDto Insurance;
    
    
    
}