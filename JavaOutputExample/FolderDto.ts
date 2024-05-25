package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class FolderDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String FolderName;
        @Nullable
    	private FileDto Files;
        @NotNull
    	private PersonDto Owner;
    
    
    
}