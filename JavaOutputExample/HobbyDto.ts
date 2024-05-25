package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class HobbyDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String Name;
        @Nullable
    	private String Description;
        @Nullable
    	private PersonDto Participants;
        @Nullable
    	private HobbyEquipmentDto Equipments;
    
    
    
}