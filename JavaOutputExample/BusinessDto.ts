package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class BusinessDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @NotNull
    	private AddressDto Location;
        @Nullable
    	private ProductDto Products;
        @Nullable
    	private PersonDto Employees;
    
    
    
}