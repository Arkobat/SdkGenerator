package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class AddressDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Street;
        @NotNull
    	private String City;
        @NotNull
    	private String State;
        @NotNull
    	private String ZipCode;
        @NotNull
    	private CountryDto Country;
        @Nullable
    	private PersonDto Residents;
        @Nullable
    	private BusinessDto Businesses;
    
    
    
}