package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class VisaDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String VisaType;
        @NotNull
    	private CountryDto IssuedBy;
        @NotNull
    	private PersonDto Holder;
        @NotNull
    	private DateTime IssueDate;
        @NotNull
    	private DateTime ExpiryDate;
    
    
    
}