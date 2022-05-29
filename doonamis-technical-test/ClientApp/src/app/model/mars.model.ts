
export interface Mars {
    Is3D: boolean;
    BaseCoordinates: number;
    Max2DCoordinates: number;
    Max3DCoordinates: number;
    Rovers: Rover[];
}

export interface Coordinates {
    X: number;
    Y: number;
    Z: number;
}

export enum OrientationEnum {
    North,
    South,
    East,
    West
}
export interface Rover {
    Name: string;
    Coordinates: Coordinates;
    Orientation: OrientationEnum;
    IsOutOfBounds: boolean;
}
