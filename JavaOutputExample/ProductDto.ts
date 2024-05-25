package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class ProductDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @Nullable
    	private String Description;
        @NotNull
    	private double Price;
        @NotNull
    	private CompanyDto Manufacturer;
        @Nullable
    	private ReviewDto Reviews;
    
    
    
}