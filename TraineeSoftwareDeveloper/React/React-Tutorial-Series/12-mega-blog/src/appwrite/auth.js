import config from '../config/config';
import {Client, Account, ID} from 'appwrite';

export class AuthService{
    client = new Client();
    account;
    
    constructor() {
        this.client
            .setEndpoint(config.appwriteUrl)
            .setProject(config.appwriteProjectId);
        
        this.account = new Account(this.client);
    }

    async createAccount({email, password, name}) {
        try {
            const userAccount = await this.account.create(ID.unique(), email, password, name);

            if(userAccount){
                // Call another method
                return this.login({email, password});

            } else {
                return userAccount;
            }
        } catch(error) {
            throw error;
        }
    }

    async login({emaill, password}) {
        try {
            return await this.account.createEmailSession(emaill, password);

        } catch (error) {
            throw error;
        }
    }

    async getCurrentUser() {
        try {
            return await this.account.get();
        } catch (error) {
            console.log('Appwrite Service :: getCurrentUser :: ERROR', error);
        }

        return null;
    }

    async logout() {
        try {
            await this.account.deleteSessions();
        } catch (error) {
            //throw error;
            console.log('Appwrite Service :: logout :: ERROR', error);
        }
    }
}

const authService = new AuthService();

// https://appwrite.io/docs/tutorials/react/step-4

export default authService;
