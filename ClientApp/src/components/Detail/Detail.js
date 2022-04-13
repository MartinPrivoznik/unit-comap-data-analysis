import React from "react";

const Detail = () => {
  return (
    <>
      <div className="row">
        <h1>IL4 PG24A</h1>
      </div>
      <div className="row">
        <h2>Chybovost produktu</h2>
      </div>
      <ul className="nav nav-pills nav-justified" role="tablist">
        <li className="nav-item waves-effect waves-light">
          <a
            className="nav-link active"
            data-bs-toggle="tab"
            href="#home-1"
            role="tab"
          >
            <span className="d-block d-sm-none">
              <i className="fas fa-home"></i>
            </span>
            <span className="d-none d-sm-block">Home</span>
          </a>
        </li>
        <li className="nav-item waves-effect waves-light">
          <a
            className="nav-link"
            data-bs-toggle="tab"
            href="#profile-1"
            role="tab"
          >
            <span className="d-block d-sm-none">
              <i className="far fa-user"></i>
            </span>
            <span className="d-none d-sm-block">Profile</span>
          </a>
        </li>
        <li className="nav-item waves-effect waves-light">
          <a
            className="nav-link"
            data-bs-toggle="tab"
            href="#messages-1"
            role="tab"
          >
            <span className="d-block d-sm-none">
              <i className="far fa-envelope"></i>
            </span>
            <span className="d-none d-sm-block">Messages</span>
          </a>
        </li>
        <li className="nav-item waves-effect waves-light">
          <a
            className="nav-link"
            data-bs-toggle="tab"
            href="#settings-1"
            role="tab"
          >
            <span className="d-block d-sm-none">
              <i className="fas fa-cog"></i>
            </span>
            <span className="d-none d-sm-block">Settings</span>
          </a>
        </li>
      </ul>

      <div className="tab-content">
        <div className="tab-pane active p-3" id="home-1" role="tabpanel">
          <p className="mb-0">
            Raw denim you probably haven't heard of them jean shorts Austin.
            Nesciunt tofu stumptown aliqua, retro synth master cleanse. Mustache
            cliche tempor, williamsburg carles vegan helvetica. Reprehenderit
            butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi,
            qui irure terry richardson ex squid. Aliquip placeat salvia cillum
            iphone. Seitan aliquip quis cardigan american apparel, butcher
            voluptate nisi qui.
          </p>
        </div>
        <div className="tab-pane p-3" id="profile-1" role="tabpanel">
          <p className="mb-0">
            Food truck fixie locavore, accusamus mcsweeney's marfa nulla
            single-origin coffee squid. Exercitation +1 labore velit, blog
            sartorial PBR leggings next level wes anderson artisan four loko
            farm-to-table craft beer twee. Qui photo booth letterpress, commodo
            enim craft beer mlkshk aliquip jean shorts ullamco ad vinyl cillum
            PBR. Homo nostrud organic, assumenda labore aesthetic magna delectus
            mollit. Keytar helvetica VHS salvia yr, vero magna velit sapiente
            labore stumptown. Vegan fanny pack odio cillum wes anderson 8-bit.
          </p>
        </div>
        <div className="tab-pane p-3" id="messages-1" role="tabpanel">
          <p className="mb-0">
            Etsy mixtape wayfarers, ethical wes anderson tofu before they sold
            out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table
            readymade. Messenger bag gentrify pitchfork tattooed craft beer,
            iphone skateboard locavore carles etsy salvia banksy hoodie
            helvetica. DIY synth PBR banksy irony. Leggings gentrify squid 8-bit
            cred pitchfork. Williamsburg banh mi whatever gluten-free, carles
            pitchfork biodiesel fixie etsy retro mlkshk vice blog. Scenester
            cred you probably haven't heard of them, vinyl craft beer blog
            stumptown. Pitchfork sustainable tofu synth chambray yr.
          </p>
        </div>
        <div className="tab-pane p-3" id="settings-1" role="tabpanel">
          <p className="mb-0">
            Trust fund seitan letterpress, keytar raw denim keffiyeh etsy art
            party before they sold out master cleanse gluten-free squid
            scenester freegan cosby sweater. Fanny pack portland seitan DIY, art
            party locavore wolf cliche high life echo park Austin. Cred vinyl
            keffiyeh DIY salvia PBR, banh mi before they sold out farm-to-table
            VHS viral locavore cosby sweater. Lomo wolf viral, mustache
            readymade thundercats keffiyeh craft beer marfa ethical. Wolf salvia
            freegan, sartorial keffiyeh echo park vegan.
          </p>
        </div>
      </div>
    </>
  );
};

export default Detail;
