package SchemaExtractor.Model.Example;
import import org.jetbrains.annotations.NotNull;
import import org.jetbrains.annotations.Nullable;

public class RoutineDto {
    
        @NotNull
    	private int Id;
        @NotNull
    	private String RoutineName;
        @NotNull
    	private PersonDto Person;
        @Nullable
    	private HabitDto Habits;
    
    
    
}