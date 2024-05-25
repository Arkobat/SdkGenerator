package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class CertificationDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private String Issuer;
        @NotNull
    	private DateTime DateIssued;
        @Nullable
    	private DateTime DateExpiry;
        @NotNull
    	private PersonDto Person;
    
    
    
}