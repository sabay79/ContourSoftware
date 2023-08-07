import React from 'react'
import "./Home.css"
import Product from './Product.js'

function Home() {
  return (
    <div className='home'>
        <div className='home__container'>
            <img className='home__image' src='amazonBanner.jpg' alt='Banner' />

            <div className='home__row'>
                <Product 
                    title="Atomic Habits: An Easy & Proven Way to Build Good Habits & Break Bad Ones"
                    price={14.99}
                    rating={5}
                    image="./AtomicHabits.jpg"
                />
                <Product 
                    title="Our Class is a Family (Our Class is a Family & Our School is a Family)" 
                    price={10.33}
                    rating={5}
                    image="./OurClassIsAFamily.jpg"
                /> 
                <Product 
                    title="The Complete Summer I Turned Pretty Trilogy (Boxed Set): The Summer I Turned Pretty; It's Not Summer Without You; We'll Always Have Summer"
                    price={21.59}
                    rating={4}
                    image="./CompleteSummerITurnedPrettyTrilogy.jpg"
                />
            </div>

            <div className='home__row'>
                <Product 
                        title="Outlive: The Science and Art of Longevity"
                        price={13.99}
                        rating={5}
                        image="./Outlive.jpg"
                />
                <Product 
                    title="The 48 Laws of Power"
                    price={13.86}
                    rating={4}
                    image="./Power.jpg"
                />
                <Product 
                    title="The Covenant of Water (Oprah's Book Club)"
                    price={19.58}
                    rating={4}
                    image="./TheCovenantOfWater.jpg"
                />
                <Product 
                    title="It Starts with Us: A Novel (2) (It Ends with Us)"
                    price={10.49}
                    rating={4}
                    image="./ItStartsWithUs.jpg"
                />
                <Product 
                        title="A Court of Thorns and Roses"
                        price={10.37}
                        rating={4}
                        image="./CourtOfThronsAndRoses.jpg"
                />
            </div>

            <div className='home__row'>
                <Product 
                    title="Rich Dad Poor Dad: What the Rich Teach Their Kids About Money That the Poor and Middle Class Do Not!"
                    price={7.49}
                    rating={4}
                    image="./RichDadPoorDad.jpg"
                />
                <Product 
                        title="Like a River: Finding the Faith and Strength to Move Forward after Loss and Heartache"
                        price={24.17}
                        rating={5}
                        image="./LikeARiver.jpg"
                />
                <Product 
                        title="The Four Agreements: A Practical Guide to Personal Freedom (A Toltec Wisdom Book)"
                        price={7.74}
                        rating={4}
                        image="./TheFourAgreements.jpg"
                />
            </div>
            
        </div>
    </div>
  )
}

export default Home
