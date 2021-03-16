import { User } from 'src/app/_models/user';
export class UserParams {
    favoriteArmy: string;
    minAge = 18;
    maxAge = 99;
    pageNumber = 1;
    pageSize = 5;
    orderBy = 'lastActive';

    constructor(user: User) {
        if(user.favoriteArmy == "order"){
            this.favoriteArmy = "order";
        }
        else if (user.favoriteArmy == "chaos"){
            this.favoriteArmy = " chaos";
        }
        else if (user.favoriteArmy == "destruction"){
            this.favoriteArmy = "destruction"
        }
        else{
            this.favoriteArmy = "death"
        }
        // this.favoriteArmy = user.favoriteArmy === "order" ? "order" : user.favoriteArmy === "chaos" ? "chaos" : user.favoriteArmy === "destruction" ? "destruction" : "death";
    }
}