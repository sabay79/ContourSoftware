import { initializeApp } from 'firebase/app';
import { getFirestore } from 'firebase/firestore/lite';
import { getAuth } from "firebase/auth";

// For Firebase JS SDK v7.20.0 and later, measurementId is optional
const firebaseConfig = {
    apiKey: "AIzaSyDbzetZNgQ5TlJHXTOg8FB9QCyvVDXVRaE",
    authDomain: "clone-10ef9.firebaseapp.com",
    projectId: "clone-10ef9",
    storageBucket: "clone-10ef9.appspot.com",
    messagingSenderId: "461644695481",
    appId: "1:461644695481:web:1659e200bb1c1d51b2d868",
    measurementId: "G-DMCZE0L3WE"
  };

// Initialize Firebase
const firebaseApp = initializeApp(firebaseConfig);

const db = getFirestore(firebaseApp);

// Initialize Firebase Authentication and get a reference to the service
const auth = getAuth(firebaseApp);

export {db, auth};