import { Photo } from "./photo";

export interface Member {
    id: number;
    userName: string;
    photoUrl: string;
    age: number;
    nickName: string;
    created: Date;
    lastActive: Date;
    favoriteArmy: string;
    bio: string;
    city: string;
    country: string;
    photos: Photo[];
}

