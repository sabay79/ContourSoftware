import styles from "./index.module.css"

export default function Card(props) {

    const{name, price} = props;

    return(
        <div className={styles.card}>
            <h3>{name} -  ${price}</h3>
        </div>
    );
}
