import "./Navigation.css";
import Logo from "../../assets/pmsLogo3.png";
import { Navbar, Container, NavDropdown } from "react-bootstrap";
import { Link } from "react-router-dom";

type Props = {};

const Navigation = (props: Props) => {
  return (
    <Navbar className="navbar">
      <Container>
        <Navbar.Brand href="#home">
          <img
            alt=""
            src={Logo}
            width="50"
            height="30"
            className="d-inline-block align-middle"
          />
          Permission Management
        </Navbar.Brand>
        <Navbar.Toggle />
        <Navbar.Collapse className="justify-content-end ">
          <NavDropdown
            title={"Kullanıcı Adı"}
            id="navbarScrollingDropdown"
            className="text-center"
          >
            <Link to="/login">Çıkış Yap</Link>
          </NavDropdown>
        </Navbar.Collapse>
      </Container>
    </Navbar>
  );
};

export default Navigation;
