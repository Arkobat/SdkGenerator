package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class VehicleDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Make;
        @NotNull
    	private String Model;
        @NotNull
    	private int Year;
        @NotNull
    	private PersonDto Owner;
        @Nullable
    	private ServiceRecordDto ServiceRecords;
    
    
    
}