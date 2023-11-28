import React from 'react';

const Card = (props) => {

    const imageSource = props.imgSource ? props.imgSource : 'https://images.unsplash.com/photo-1554412661-828c8d34bb9c?q=80&w=1542&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D';
    const product = props.product ? props.product : 'Macbook';
    const btnText = props.btnText ? props.btnText : 'Read More';

    return (
        <>
            <div className="w-[300px] rounded-md border">
                <img
                    src={imageSource}
                    alt={product}
                    className="h-[200px] w-full rounded-t-md object-cover"
                />
                <div className="p-4">
                    <h1 className="inline-flex items-center text-lg font-semibold">
                        About {product}  {" "}
                        <svg
                            xmlns="http://www.w3.org/2000/svg"
                            width="24"
                            height="24"
                            viewBox="0 0 24 24"
                            fill="none"
                            stroke="currentColor"
                            stroke-width="2"
                            stroke-linecap="round"
                            stroke-linejoin="round"
                            className="h-4 w-4"
                        >
                            <line x1="7" y1="17" x2="17" y2="7"></line>
                            <polyline points="7 7 17 7 17 17"></polyline>
                        </svg>
                    </h1>
                    <p className="mt-3 text-sm text-gray-600">
                        Lorem ipsum dolor sit amet consectetur adipisicing elit. Excepturi,
                        debitis?
                    </p>
                    <button
                        className="mt-4 w-full rounded-sm bg-black px-2 py-1.5 text-sm font-semibold text-white shadow-sm hover:bg-black/80 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-black"
                    >
                        {btnText}
                    </button>
                </div>
            </div>
        </>
    );
}

export default Card;
