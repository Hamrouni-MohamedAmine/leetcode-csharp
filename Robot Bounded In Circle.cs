public class Solution {
    public bool IsRobotBounded(string instructions) {
        int[][] directions = new int[][]{
            new int[]{1,0},
            new int[]{0,1},
            new int[]{-1,0},
            new int[]{0,-1}
        };
        
        int[] position = new int[]{0,0};
        int[] selectedDirection = directions[0];
        int selectedDirectionIndex = 0;
        
        for(int i = 0; i< instructions.Length; i++){
            if(instructions[i] == 'G'){
                position[0]  += 1 * selectedDirection[0];
                position[1]  += 1 * selectedDirection[1] ;
            }else if(instructions[i] == 'L'){
                selectedDirectionIndex = (selectedDirectionIndex + 1 +directions.Length) % directions.Length;
                selectedDirection = directions[selectedDirectionIndex];
            }else if(instructions[i] == 'R'){
                selectedDirectionIndex = (selectedDirectionIndex - 1 + directions.Length) % directions.Length;
                selectedDirection = directions[selectedDirectionIndex];
            }
        }
        return position.SequenceEqual(new int[]{0,0}) ||  selectedDirectionIndex != 0;
    }
}