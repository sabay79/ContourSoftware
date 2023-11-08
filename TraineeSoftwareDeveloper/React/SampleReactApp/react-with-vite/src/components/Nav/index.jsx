import styles from "./index.module.css"

export default function Nav() {
    return(
        <nav className={styles.nav}>
            <h3>NavBar</h3>
            <ul>
                <li>Home</li>
                <li>About</li>
                <li>Contact</li>
            </ul>
        </nav>
    );
}
