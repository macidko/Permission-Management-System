import "./Navigation.css";
import Logo from "../../assets/pmsLogo3.png";
import { Navbar, Container } from "react-bootstrap";

type Props = {};

const Navigation = (props: Props) => {
  return (
    <Navbar className="bg-body-tertiary">
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
      </Container>
    </Navbar>
  );
};

export default Navigation;
