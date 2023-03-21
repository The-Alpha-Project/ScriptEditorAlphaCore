namespace ScriptEditor
{
    public class Waypoint
    {
        public uint Id;
        public uint Point;
        public float Position_x;
        public float Position_y;
        public float Position_z;
        public float Orientation;
        public uint Waittime;
        public float Wander_distance;
        public uint Script_id;

        public Waypoint(uint id, uint point, float position_x, float position_y, float position_z, float orientation, uint waittime, float wander_distance, uint script_id)
        {
            Id = id;
            Point = point;
            Position_x = position_x;
            Position_y = position_y;
            Position_z = position_z;
            Orientation = orientation;
            Waittime = waittime;
            Wander_distance = wander_distance;
            Script_id = script_id;
        }

        public Waypoint(uint id, uint point)
        {
            Id = id;
            Point = point;
            Position_x = 0;
            Position_y = 0;
            Position_z = 0;
            Orientation = 0;
            Waittime = 0;
            Wander_distance = 0;
            Script_id = 0;
        }
    }
}
