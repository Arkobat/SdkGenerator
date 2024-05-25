package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class WorkshopDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String WorkshopName;
        @NotNull
    	private DateTime Date;
        @NotNull
    	private AddressDto Location;
        @Nullable
    	private SessionDto Session;
    
    
    
}