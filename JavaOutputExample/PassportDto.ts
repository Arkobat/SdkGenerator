package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class PassportDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String PassportNumber;
        @NotNull
    	private PersonDto Holder;
        @NotNull
    	private DateTime IssueDate;
        @NotNull
    	private DateTime ExpiryDate;
        @Nullable
    	private VisaDto Visa;
    
    
    
}